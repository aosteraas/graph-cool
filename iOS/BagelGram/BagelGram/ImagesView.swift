//
//  ImagesView.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 21/11/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import SwiftUI


struct PageView<Page: View>: View {
    var viewControllers: [UIHostingController<Page>]


    init(_ views: [Page]) {
        self.viewControllers = views.map { UIHostingController(rootView: $0) }
    }


    var body: some View {
        PageViewController(controllers: viewControllers)
    }
}


struct PageView_Preview: PreviewProvider {
    static var previews: some View {
        PageView(features.map)
    }
}
