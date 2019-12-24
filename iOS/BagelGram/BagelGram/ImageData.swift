//
//  ImageData.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 25/12/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import Foundation

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
