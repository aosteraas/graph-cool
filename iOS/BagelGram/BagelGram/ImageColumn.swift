//
//  ImageColumn.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 25/12/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import SwiftUI

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

