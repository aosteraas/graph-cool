//
//  ContentView.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 19/11/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import SwiftUI
import Apollo
import Network


class ImageData: ObservableObject {
    @Published var data: [GetImagesQuery.Data.GetImage]
    
    init() {
        self.data = []
        loadData()
    }
    
    func loadData() {
        Server.shared.apollo.fetch(query: GetImagesQuery()) { result in
            guard let data = try? result.get().data else { return }

            if let stuff = data.getImages?.compactMap({$0}) {
                self.data = stuff
            }
        }
    }
}

struct ContentView: View {
    private let bagelPink = UIColor(red: 0.95805620825129523, green: 0.28210045499878755, blue: 1, alpha: 1)
    private let bagelFont = UIFont(name: "Chalkboard SE", size: 20)
    
    
    init() {
        let navAppearance = UINavigationBar.appearance()
        navAppearance.barTintColor = bagelPink
        navAppearance.titleTextAttributes = [
            .font: bagelFont!,
            .foregroundColor: UIColor.white
        ]
    }
    
    var body: some View {
        NavigationView {
            ImageColumn()
            .navigationBarTitle("BagelGram", displayMode: .inline)
        }


    }
}

struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        ContentView()
    }
}


struct ImageColumn: View {
    @ObservedObject private var data = ImageData()
    init() {
        // remove extra separators below the list
        UITableView.appearance().tableFooterView = UIView()
        // remove all separators including the actual ones:
        UITableView.appearance().separatorStyle = .none
    }

    var body: some View {
        
        VStack(alignment: .leading) {
            List (data.data, id: \.id) { imageItem in
                VStack {
                    ImageLoadingView(url: URL(string: "http://localhost:5000\(imageItem.source)")!)
                    HStack(alignment: .firstTextBaseline) {
                        Text("Bagel")
                            .font(Font.custom("Chalkboard SE", size: 20))
                            .bold()
                            .frame(minWidth: 0, alignment: .leading)
                        Text(imageItem.caption)
                            .font(Font.custom("Chalkboard SE", size: 20))
                            .frame(minWidth: 0, alignment: .leading)
                    }
                    
                    HStack {
                        Text("Posted \(imageItem.uploaded)")
                            .font(Font.custom("Chalkboard SE", size: 16))
                            .frame(minWidth: 0, maxWidth: .infinity, alignment: .leading)
                    }
                    
                        
                }
            }
        }
    .offset(y: 10)
    .fixedSize(horizontal: false, vertical: false)
    }
}
